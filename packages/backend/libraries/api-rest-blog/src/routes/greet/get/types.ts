import { IGreetingModule } from "@blog/backend-lib-core/src/modules/greeting/types";

export interface IGreetingParams {
  name: string;
}

declare module "fastify" {
  interface FastifyRequest {
    greeting: IGreetingModule;
  }
}
