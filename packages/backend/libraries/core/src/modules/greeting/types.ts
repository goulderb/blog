export type GreeterFn = (name: string) => string;

export interface IGreetingModule {
  greet: GreeterFn;
}
