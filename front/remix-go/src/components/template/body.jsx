import React from 'react';

function Body({ content }) {

    return <>
        <section className="page-section portfolio" id="portfolio">
            <div className="container pt-5">
                {content}
            </div>
        </section>
        <iframe title="roller" src={`http://a.teall.info/dice/?notation=${1}d${10}&roll`} frameBorder={0} style={{ position: 'absolute', overflow: 'hidden', bottom: 0, width: '100%', height: 400 }} />
    </>;
}

export default Body;