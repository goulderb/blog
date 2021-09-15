import greet from "./greet";

describe("Greeting module", () => {
  it("Format a greeting", () => {
    const greeting = greet("Brett");

    expect(greeting).toBe("Hello, Brett!");
  });
});
