import React from "react";
import {
  LineChart,
  Line,
  XAxis,
  YAxis,
  CartesianGrid,
  Tooltip,
  Legend,
  ResponsiveContainer
} from "recharts";

const data = [
  { month: "Jan", sales: 4000, profit: 2400 },
  { month: "Feb", sales: 3000, profit: 2210 },
  { month: "Mar", sales: 2000, profit: 2290 },
  { month: "Apr", sales: 2780, profit: 2000 },
  { month: "May", sales: 1890, profit: 2181 },
  { month: "Jun", sales: 2390, profit: 2500 },
  { month: "Jul", sales: 3490, profit: 2100 },
];

export default function SalesLineChart() {
  return (
    <div className="w-full h-96">
      <ResponsiveContainer width="100%" height="100%">
        <LineChart data={data} width={300} height={500}
          margin={{ top: 20, right: 30, left: 20, bottom: 10 }}
        >
          <CartesianGrid strokeDasharray="3 3" />
          <XAxis dataKey="month" />
          <YAxis />
          <Tooltip />
          <Legend />
          <Line type="monotone" dataKey="sales" stroke="#8884d8" strokeWidth={2} />
          <Line type="monotone" dataKey="profit" stroke="#82ca9d" strokeWidth={2} />
        </LineChart>
      </ResponsiveContainer>
    </div>
  );
}
