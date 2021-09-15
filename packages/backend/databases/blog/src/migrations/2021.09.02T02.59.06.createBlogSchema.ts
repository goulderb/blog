import { Migration } from "@slonik/migrator";

export const up: Migration = async ({ context: { connection, sql } }) => {
  await connection.query(sql`
    CREATE SCHEMA blog;

    CREATE TABLE blog.post
    (
      id VARCHAR(29) NOT NULL,
      title VARCHAR NOT NULL,
      body VARCHAR NOT NULL,
      published_date TIMESTAMP NOT NULL,

      PRIMARY KEY
      (
        id
      )
    );
  `);
};

export const down: Migration = async ({ context: { connection, sql } }) => {
  await connection.query(sql`
    DROP TABLE blog.post;

    DROP SCHEMA blog;
  `);
};
