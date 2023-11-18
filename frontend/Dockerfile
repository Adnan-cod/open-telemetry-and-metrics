
FROM node:16-alpine 
# Set the working directory to /app inside the container
WORKDIR /app
# ==== BUILD =====
# Install dependencies (npm ci makes sure the exact versions in the lockfile gets installed)
COPY **/package*.json .
RUN npm ci 
 
# Copy app files
COPY  . /app
RUN ls -la

RUN npm run build 
ENV NODE_ENV production
 
EXPOSE 3000
# Start the app
CMD ["npm", "start"]