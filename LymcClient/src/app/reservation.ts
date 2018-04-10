export class Reservation {
    boatName: string;
    startDateTime: Date;
    endDateTime: Date;
    itinerary: string;
    allocatedCredit: number;
    allocatedHours: number;
    user: string;

    constructor(obj?: any) {
        this.boatName = obj && obj.boatName || null;
        this.startDateTime = obj && obj.startDateTime || null;
        this.endDateTime = obj && obj.endDateTime || null;
        this.itinerary = obj && obj.itinerary || null;
        this.allocatedCredit = obj && obj.allocatedCredit || null;
        this.allocatedHours = obj && obj.allocatedHours || null;
        this.user = obj && obj.user || null;

    }
}
