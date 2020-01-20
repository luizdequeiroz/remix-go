import React from "react";
import Header from './header';
import Body from './body';

function Template({ children }) {
  return (
    <>
      <Header />
      <Body content={children} />      
    </>
  );
}

export default Template;
