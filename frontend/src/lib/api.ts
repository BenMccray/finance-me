import { Axios } from "axios";

export const api = new Axios({
  baseURL: "http://localhost:8000/api",
  headers: {
    "Content-Type": "application/json",
    "Accept": "application/json",
  },
  responseType: "json",
  timeout: 5000,
  withCredentials: true,
});