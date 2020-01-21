import React, { useEffect } from "react";
import Header from './header';
import Body from './body';
import Status from './status';
import Login from './login';
import { connect } from 'react-redux';
import { bindDefault } from "react-binder-generalizers";
import Swal from 'sweetalert2';

function Template({ setValue, session, children }) {

  useEffect(() => {
    const session = JSON.parse(sessionStorage.getItem('session'));
    if (session) {
      setValue('session', session);
    }
  }, [setValue]);

  useEffect(() => {
    if (session) {
      if (session.result) {
        sessionStorage.setItem('session', JSON.stringify(session))
      } else {
        Swal.fire({
          title: session.message,
          type: 'error'
        });
      }
    }
  }, [session]);

  return (
    <>
      {session && session.result ?
        <>
          <Header />
          <Body content={children} />
        </>
        : <Login />
      }
      <Status />
    </>
  );
}

export default bindDefault(connect)('session')(Template);