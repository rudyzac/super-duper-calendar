FROM node:16-alpine AS development
RUN apk add --no-cache bash
ENV NODE_ENV=development

WORKDIR /app

COPY package.json .
COPY package-lock.json .

RUN npm install
RUN mkdir -p node_modules/.cache && chmod -R 777 node_modules/.cache

COPY . .

EXPOSE 3000

CMD ["npm", "start"]
