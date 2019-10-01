import { Superhero } from "./superhero.model";

export class CreateSuperhero extends Superhero {
    constructor(id: number, name: string, description: string, imageUrl: string, public file: File) {
        super(id, name, description, file.name);
    }
}
