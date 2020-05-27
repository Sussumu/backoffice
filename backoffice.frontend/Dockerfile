FROM mhart/alpine-node:14.2 as base
WORKDIR /app
COPY package*.json ./

RUN npm i

COPY . .

EXPOSE 8080
CMD ["npm", "run", "serve"]