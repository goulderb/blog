FROM node:14.17.6-alpine AS blog-project

WORKDIR /app

COPY ./ /app
RUN yarn install
RUN yarn run bootstrap
RUN yarn run build

FROM blog-project AS runner

WORKDIR /app/packages/backend/servers/http

EXPOSE 3000
CMD ["yarn", "start"]