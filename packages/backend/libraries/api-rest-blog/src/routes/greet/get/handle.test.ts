import { FastifyRequest, FastifyReply } from "fastify";
import { IGreetingParams } from "./types";
import handle from "./handle";
import { GreeterFn } from "@blog/core/src/modules/greeting/types";

describe("/greet/:name", () => {
  it("Should return the value from the greeter.", () => {
    const request = {
      params: {
        name: "Brett",
      },
      greeting: {
        greet: jest.fn((name) => name) as GreeterFn,
      },
    } as FastifyRequest<{ Params: IGreetingParams }>;

    const reply = {
      send: jest.fn(),
    } as unknown as FastifyReply;

    handle(request, reply);

    expect(request.greeting.greet).toHaveBeenCalledWith("Brett");
    expect(reply.send).toHaveBeenCalledWith("Brett");
  });
});
