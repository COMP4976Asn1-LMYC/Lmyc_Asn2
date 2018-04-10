export class Boat {

    boatId: number;
    boatName: string;
    picture: string;
    lengthInFeet: number;
    make: string;
    year: number;
    creationDate: Date;
    createdBy: Date;
    user: string;

    constructor(obj?: any) {
        this.boatId = obj && obj.boatId || null;
        this.boatName = obj && obj.boatName || null;
        this.picture = obj && obj.picture || null;
        this.lengthInFeet = obj && obj.lengthInFeet || null;
        this.make = obj && obj.make || null;
        this.year= obj && obj.year || null;
        this.creationDate = obj && obj.creationDate || null;
        this.createdBy= obj && obj.createdBy || null;
        this.user = obj && obj.user || null;

    }
}
