import { Entrega } from "./Entrega";

export interface Carga {

  id: number;
  peso: number;
  altura: number;
  comprimento: number;
  largura: number;
  data_Entrega: Date;
  entregaId: number;
  entrega: Entrega;
}
