import { FastifyPluginAsync } from "fastify";
import greetGetRoute from "./routes/greet/get";
import { GreetingModule } from "@blog/backend-lib-core";

const plugin: FastifyPluginAsync = async (instance) => {
  instance.decorateRequest("greeting", GreetingModule());

  greetGetRoute(instance);
};

export default plugin;
