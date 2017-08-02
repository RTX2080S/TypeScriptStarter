
export class Meal {

    public id: KnockoutObservable<number>;
    public mealName: KnockoutObservable<string>;
    public price: KnockoutObservable<any>;

    constructor(data: any) {
        console.log(data);
        this.id = ko.observable(data.Id);
        this.mealName = ko.observable(data.Name);
        this.price = ko.observable(data.Price);
    }
}
