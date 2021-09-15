require("ts-node/register/transpile-only");

import { SlonikMigrator } from "@slonik/migrator";
import { createPool } from "slonik";
import { join as pathJoin } from "path";
import { config as dotEnvConfig } from "dotenv";

dotEnvConfig();

const CONNECTION_STRING = process?.env?.POSTGRES_CONNECTION_STRING ?? "";
const MIGRATION_PATH = process?.env?.MIGRATION_PATH ?? "../migrations";

const slonik = createPool(CONNECTION_STRING);

const migrator = new SlonikMigrator({
  migrationsPath: pathJoin(__dirname, MIGRATION_PATH),
  migrationTableName: "migrations",
  slonik,
  logger: {
    // eslint-disable-next-line no-console
    info: console.log,
    // eslint-disable-next-line no-console
    warn: console.log,
    // eslint-disable-next-line no-console
    debug: console.log,
    // eslint-disable-next-line no-console
    error: console.error,
  },
});

migrator.runAsCLI();
