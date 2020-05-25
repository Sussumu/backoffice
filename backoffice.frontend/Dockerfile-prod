FROM mhart/alpine-node:14.2 as base
WORKDIR /app
COPY package.json package-lock.json ./

RUN npm i
COPY . .
RUN npm run build

FROM nginx:stable-alpine as production-stage
COPY --from=base /app/dist /usr/share/nginx/html
EXPOSE 80
EXPOSE 443
CMD ["nginx", "-g", "daemon off;"]