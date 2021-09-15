export type ModuleFn<IModule, IDependencies = void> = (
  dependencies: IDependencies
) => IModule;
