import React from "react";
import ReactDOM from "react-dom";
import axios from "axios";
import App from "./App";

axios.defaults.baseURL = `${process.env.REACT_APP_CORE_SERVER}/api`;
axios.defaults.headers.post["Content-Type"] = "application/json";

axios.interceptors.request.use(
  request => {
    // Logging to assist with development
    if (!process.env.NODE_ENV || process.env.NODE_ENV === "development") {
      console.log(request);
    }
    return request;
  },
  error => {
    if (error.request) {
      // The request was made but no response was received
      // `error.request` is an instance of XMLHttpRequest in the browser and an instance of
      // http.ClientRequest in node.js
      console.log(error.request);
    } else {
      // Something happened in setting up the request that triggered an Error
      console.log("Error", error.message);
    }
    console.log(error.config);

    return Promise.reject(error);
  }
);

axios.interceptors.response.use(
  response => {
    // Logging to assist with development
    if (!process.env.NODE_ENV || process.env.NODE_ENV === "development") {
      console.log(response);
    }

    return response;
  },
  error => {
    if (error.response) {
      // The request was made and the server responded with a status code
      // that falls out of the range of 2xx
      console.log(error.response.data);
      console.log(error.response.status);
      console.log(error.response.headers);
    } else {
      // Something happened in setting up the request that triggered an Error
      console.log("Error", error.message);
    }
    console.log(error.config);

    return Promise.reject(error);
  }
);

ReactDOM.render(<App />, document.getElementById("root"));
