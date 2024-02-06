import React, { useEffect, useState } from 'react';
import axios, { AxiosResponse } from 'axios';

const fetchData = async (apiUrl: string): Promise<any> => {
  try {
    const response = await axios.get(apiUrl);
    return response.data;
  } catch (error) {
    console.error('Error fetching data:', error);
    throw error;
  }
};

const App: React.FC = () => {
  const [categories, setCategories] = useState<any[]>([]);
  const [eventParticipants, setEventParticipants] = useState<any[]>([]);
  const [orders, setOrders] = useState<any[]>([]);

  // le observam in F12
  useEffect(() => {
    axios.get('https://localhost:7226/api/Categories')
      .then((response: AxiosResponse<any>) =>{
        console.log(response.data);
      })
  }, [])
  useEffect(() => {
    axios.get('https://localhost:7226/api/EventParticipant')
      .then((response: AxiosResponse<any>) =>{
        console.log(response.data);
      })
  }, [])

  useEffect(() => {
    axios.get('https://localhost:7226/api/Orders')
      .then((response: AxiosResponse<any>) =>{
        console.log(response.data);
      })
  }, [])


  return (
    <>
      <h1>My React App</h1>

      <div>
        <h2>Categories</h2>
        <ul>
          {categories.map((category, index) => (
            <li key={index}>{category.name}</li>
          ))}
        </ul>
      </div>

      <div>
        <h2>Event Participants</h2>
        <ul>
          {eventParticipants.map((participant, index) => (
            <li key={index}>{participant.name}</li>
          ))}
        </ul>
      </div>

      <div>
        <h2>Orders</h2>
        <ul>
          {orders.map((order, index) => (
            <li key={index}>{order.orderName}</li>
          ))}
        </ul>
      </div>
    </>
  );
};

export default App;