import React from 'react'

import { Container } from '../../styles/pages/home'
import Navbar from '../navbar'

const Orders: React.FC = () => {
  return (
    <>
      <Navbar />
      <Container>
        <div>MY ORDERS</div>
      </Container>
    </>
  )
}
export default Orders
