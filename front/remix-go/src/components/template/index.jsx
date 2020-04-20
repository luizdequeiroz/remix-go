import React, { useEffect } from "react";
import { useApply, useReducers } from 'react-resaga';
import Header from './header';
import Body from './body';
import Status from './status';
import Login from './login';
import Swal from 'sweetalert2';

function Template({ children }) {
  const apply = useApply();
  const { session } = useReducers('session');

  useEffect(() => {
    const _session = JSON.parse(sessionStorage.getItem('session'));
    if (_session) {
      apply('session', _session);
    }
  }, []); // eslint-disable-line

  useEffect(() => {
    if (session) {
      if (session.result) {
        sessionStorage.setItem('session', JSON.stringify(session))
      } else {
        Swal.fire({
          title: session.message,
          icon: 'error'
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

export default Template;