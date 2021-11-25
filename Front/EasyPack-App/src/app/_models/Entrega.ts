import { Carga } from "./Carga";

export interface Entrega {
    id: number;

    data_Coleta: Date;

    cargas: Carga[];
}
