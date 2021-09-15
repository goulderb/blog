import { fastify } from "fastify";
import ApiRestBlog from "@blog/backend-lib-api-rest-blog";

const main = async () => {
  const server = fastify({
    logger: {
      level: "trace",
    },
  });

  server.register(ApiRestBlog);

  server.listen(3000, "::");
};

main().catch(console.error);
