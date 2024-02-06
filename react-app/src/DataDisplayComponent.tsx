// src/components/DataDisplayComponent.tsx
import React, { useEffect, useState } from 'react';
import axios, { AxiosResponse } from 'axios';
import myPipe from './pipes';

const DataDisplayComponent: React.FC<{ apiUrl: string }> = ({ apiUrl }) => {
  const [data, setData] = useState<any[]>([]);

  useEffect(() => {
    axios.get(apiUrl)
      .then((response: AxiosResponse<any>) => {
        setData(response.data);
      })
      .catch((error) => {
        console.error('Error fetching data:', error);
      });
  }, [apiUrl]);

  return (
    <div>
      <h2>Data Display Component</h2>
      <ul>
        {data.map((item: any, index: number) => (
          <li key={index}>{myPipe(item.name)}</li>
        ))}
      </ul>
    </div>
  );
};

export default DataDisplayComponent;
