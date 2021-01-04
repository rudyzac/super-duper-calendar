import { Injectable } from '@angular/core';

export interface Event {
  id: string;
  title: string;
  allDay: boolean;
  startDate: string;
  endDate: string;
}

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor() { }
}
