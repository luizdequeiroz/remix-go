import React from "react";
import { FaFile, FaHome, FaCheckCircle, FaDiceD20 } from "react-icons/fa";
import MenuSection from "./template/menuSection";

function Cards() {
  return <h1>Fichas</h1>;
}

function Tables() {
  return <h1>Mesas</h1>;
}

function Players() {
  return <h1>Jogadores</h1>;
}

export default [
  {
    exact: true,
    path: "/",
    icon: <FaDiceD20 />,
    name: "Menu",
    component: MenuSection,
    isMenuItem: false,
    image: require("../assets/img/portfolio/game.png")
  },
  {
    path: "/cards",
    icon: <FaHome />,
    name: "Fichas",
    component: Cards,
    isMenuItem: true,
    image: require("../assets/img/portfolio/cabin.png")
  },
  {
    path: "/tables",
    icon: <FaFile />,
    name: "Mesas",
    component: Tables,
    isMenuItem: true,
    image: require("../assets/img/portfolio/cake.png")
  },
  {
    path: "/players",
    icon: <FaCheckCircle />,
    name: "Jogadores",
    component: Players,
    isMenuItem: true,
    image: require("../assets/img/portfolio/circus.png")
  }
];
