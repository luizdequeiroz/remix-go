import React from "react";
import { FaFile, FaHome, FaCheckCircle } from "react-icons/fa";

function RouteOne() {
  return "Route One";
}

function RouteTwo() {
  return "Route Two";
}

function RouteThree() {
  return "Route Three";
}

export default [
  {
    exact: true,
    path: "/",
    icon: <FaHome />,
    name: "Rota Um",
    component: RouteOne,
    isMenuItem: true
  },
  {
    path: "/route-two",
    icon: <FaFile />,
    name: "Rota Dois",
    component: RouteTwo,
    isMenuItem: true
  },
  {
    path: "/route-three",
    icon: <FaCheckCircle />,
    name: "Rota Três",
    component: RouteThree,
    isMenuItem: false
  }
];
