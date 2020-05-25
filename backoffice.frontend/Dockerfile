FROM mhart/alpine-node:14.2 as base
WORKDIR /app
COPY package.json package-lock.json ./

RUN npm i

COPY . /app

EXPOSE 8080
CMD [ "npm", "run", "serve"]