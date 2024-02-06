// src/directives/MyDirective.tsx
import React from 'react';

interface MyDirectiveProps {
  condition: boolean;
  children: React.ReactNode;
}

const MyDirective: React.FC<MyDirectiveProps> = ({ condition, children }) => {
  return condition ? <>{children}</> : null;
};

export default MyDirective;
