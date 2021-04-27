import React from 'react'

import { Container } from '../styles/pages/home'
import Navbar from './navbar'

const Home: React.FC = () => {
  return (
    <>
      <Navbar />
      <Container>
        <div>HOME PAGE !</div>
      </Container>
    </>
  )
}
export default Home
