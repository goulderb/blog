import greet from "./greet";
import { IGreetingModule } from "./types";
import { ModuleFn } from "../types";

const greetingModule: ModuleFn<IGreetingModule> = () => ({
  greet,
});

export default greetingModule;
