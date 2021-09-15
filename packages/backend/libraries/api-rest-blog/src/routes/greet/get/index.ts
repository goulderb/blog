import { FastifyInstance } from "fastify";
import { IGreetingParams } from "./types";
import handle from "./handle";

export default (instance: FastifyInstance) =>
  instance.get<{
    Params: IGreetingParams;
  }>("/greet/:name", handle);
