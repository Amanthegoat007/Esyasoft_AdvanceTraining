import React from 'react'
import { Bar, BarChart, CartesianGrid, Legend, Line, LineChart, Tooltip, XAxis, YAxis } from "recharts";
const Barchart = () => {
    const data = [
        { month: "jan", sales: 3000 },
        { month: "feb", sales: 4000 },
        { month: "mar", sales: 5000 },
        { month: "apr", sales: 4000 },
        { month: "may", sales: 7000 },
        { month: "jun", sales: 1000 },
      ];
  return (
    <div>
       <BarChart width={500} height={300} data={data}>
        <XAxis dataKey="month" />
        <YAxis/>
        <Tooltip />
        <Legend/>
        <Bar dataKey="sales" fill="green"/>
        <CartesianGrid stroke="#f5f5f5" />
      </BarChart>
    </div>
  )
}

export default Barchart
