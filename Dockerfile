FROM node:18-alpine
WORKDIR /rookecomshop-admin
COPY . .
RUN npm install
CMD [ "node",  "src/main.tsx" ]
EXPOSE 5173