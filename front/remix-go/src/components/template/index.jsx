import React from "react";
import Header from './header';

function Template({ children }) {
  return (
    <>
      <Header />
      <section className="page-section portfolio" id="portfolio">
        <div className="container">
          <h2 className="page-section-heading text-center text-uppercase text-secondary mb-0">Remix Go</h2>
          {children}          
        </div>
      </section>      
    </>
  );
}

export default Template;
