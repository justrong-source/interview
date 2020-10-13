import React from "react";
import {
  BrowserRouter as Router,
  Switch as RRSwitch,
  Route,
  useLocation
} from "react-router-dom";
import { CssBaseline } from "@material-ui/core";
import Communications from "./communications";
import CommunicationDetail from "./communications/detail";

function Switch() {
  const location = useLocation();

  return (
      <RRSwitch location={location}>
        <Route exact path="/" component={Communications} />
        <Route exact path="/:id" component={CommunicationDetail} />
      </RRSwitch>
  );
}

function App() {
  return (
        <>
          <CssBaseline />
          <Router>
              <Switch />
          </Router>
        </>
  );
}

export default App;
