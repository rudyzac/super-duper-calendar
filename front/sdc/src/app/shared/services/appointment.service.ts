import { Injectable } from '@angular/core';

export interface Appointment {
  id: number;
  title: string;
  allDay: boolean;
  startDate: string;
  endDate: string;
}

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor() { }
}
