import axios from "axios";

export default axios.create({
    baseURL: process.env.API_URL || "http://localhost:8080/api",
    headers: {
        "Content-type": "application/json"
    }
});