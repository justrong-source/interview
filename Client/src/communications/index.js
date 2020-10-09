import React, { useState, useEffect } from "react";
import axios from "axios";
import { Table, TableRow, TableCell, TableBody, TableHead, Button, TableContainer  } from "@material-ui/core";

export default function Communications() {
const [loading, setLoading] = useState(true);
const [communications, setCommunications] = useState();

const getCommunications = () => {
  setLoading(true);

  axios.get("/Communications")
  .then(function (response) {
    console.log(response);
    setCommunications(response.data);
    setLoading(false);
  })
  .catch(function (error) {
    // handle error
    console.log(error);
  })
}

  useEffect(() => {
    getCommunications();
  }, []);

  if(loading){
    return <div>Loading...</div>
  }

  //TODO: Make individual rows clickable so you can drill down into the details
  return (
    <>
    <Button variant="contained" color="primary">
      Create New
    </Button>
    <TableContainer>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>From</TableCell>
            <TableCell>To</TableCell>
            <TableCell>Subject</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {communications.map((row) => (
            <TableRow key={row.id}>
              <TableCell>{row.from}</TableCell>
              <TableCell>{row.to}</TableCell>
              <TableCell>{row.subject}</TableCell>
            </TableRow>
          ))}
        </TableBody>
        </Table>
      </TableContainer>
      </>
  );
}