import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Member, Occupation } from '../models/member';

@Component({
  selector: 'app-counter-component',
  templateUrl: './member-premium.component.html',
  styleUrls: ['./member-premium.component.scss']
})
export class CounterComponent {
  public occupations: Occupation[] = [];
  public DeathPremium = 0;
  public member: FormGroup;
  public isSubmitted = false;
  constructor(fb: FormBuilder, private http: HttpClient) {
    // load occupations from api service
    http.get<Occupation[]>('api/Occupation').subscribe((result) => {
      this.occupations = result;
    }, error => console.error(error));
    this.member = fb.group({
      name: ['', Validators.required],
      age: ['', Validators.required],
      date_of_birth: ['', Validators.required],
      death_sum_insured: ['', Validators.required],
      occupation: ['', Validators.required],
      rating: [''],
      factor: [''],
    });
  }
  calculate_Age() {
    debugger
    let dob = new Date(this.member.controls['date_of_birth'].value);
    let diff_ms = Date.now() - dob.getTime();
    let age_dt = new Date(diff_ms);
    let ageFromDob = Math.abs(age_dt.getUTCFullYear() - 1970);
    this.member.patchValue({ age: ageFromDob });
  }
  get f(): { [key: string]: AbstractControl } {
    return this.member.controls;
  }

  onOccupation_Select() {
    this.isSubmitted = true;
    let occp: Occupation = this.occupations.find(o => o.id === +this.member.controls['occupation'].value) as Occupation;
    this.member.patchValue({ rating: occp.rating, factor: occp.rating_factor });
    if (this.member.valid) {
      let formData: any = this.member.value;
      let memberPremiumDetails: Member = {
        name: formData.name,
        age: formData.age,
        date_of_birth: formData.date_of_birth,
        death_sum_insured: formData.death_sum_insured,
        occupation: this.occupations.find(o => o.id === +formData.occupation) as Occupation
      };
      //Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12
      //this.DeathPremium = (memberPremiumDetails.death_sum_insured * memberPremiumDetails.occupation?.rating_factor * memberPremiumDetails.age) / 1000 * 12;

      this.http.post<number>('api/Member', memberPremiumDetails).subscribe((result) => {
        this.DeathPremium = result;
      }, error => console.error(error));
    }
  }
}
