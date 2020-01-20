import React from 'react';

function Body({ content }) {

    return (
        <section className="page-section portfolio" id="portfolio">
            <div className="container">
                <h2 className="page-section-heading text-center text-uppercase text-secondary mb-0">Remix Go</h2>
                {content}
            </div>
        </section>
    );
}

export default Body;