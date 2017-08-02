
export class Meal {

    public id: KnockoutObservable<number>;
    public mealName: KnockoutObservable<string>;
    public price: KnockoutObservable<any>;

    constructor(data: any) {
        console.log(data);
        this.id = ko.observable(data.id);
        this.mealName = ko.observable(data.name);
        this.price = ko.observable(data.price);
    }
}
