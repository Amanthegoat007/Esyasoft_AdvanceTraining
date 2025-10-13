import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";

import "./App.css";
import Barchart from "./components/charts/Barchart";
import LineChart from "./components/charts/LineChart";
import SalesLineChart from "./components/charts/LineChart";


function App() {
  const [count, setCount] = useState(0);
  

  return (
    <>
      <div className="p-10 mt-2 font-extrabold text-amber-300 w-full h-full">This is GG!</div>
      {/* <Barchart/> */}
      {/* <Linechart/>
       */}
       <SalesLineChart/>
    </>
  );
}

export default App;
