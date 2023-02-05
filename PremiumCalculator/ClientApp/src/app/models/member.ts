export interface Member {
    name: string;
    age: number;
    date_of_birth: Date;
    death_sum_insured: number;
    occupation: Occupation;
}

export interface Occupation {
    id: number;
    occupation_desc: string;
    rating: string;
    rating_factor: number;
}