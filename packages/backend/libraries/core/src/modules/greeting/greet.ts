import { GreeterFn } from "./types";

const greet: GreeterFn = (name: string): string => `Hello, ${name}!`;

export default greet;
