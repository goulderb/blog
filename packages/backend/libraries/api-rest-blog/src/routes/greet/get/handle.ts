import { FastifyRequest, FastifyReply } from "fastify";
import { IGreetingParams } from "./types";

const handler = async (
  request: FastifyRequest<{ Params: IGreetingParams }>,
  reply: FastifyReply
) => {
  const {
    params: { name },
    greeting,
  } = request;

  reply.send(greeting.greet(name));
};

export default handler;
