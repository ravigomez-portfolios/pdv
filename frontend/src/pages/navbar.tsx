import React from 'react'

import { Nav, Logo, Hamburger, Menu, MenuLink } from '../styles/pages/navbar'

const Navbar: React.FC = () => {
  return (
    <Nav>
      <Logo href="/">
        Simple <span>PDV</span>
      </Logo>
      <Hamburger>
        <span></span>
        <span></span>
        <span></span>
      </Hamburger>
      <Menu>
        <MenuLink href="/orders">Orders</MenuLink>
        <MenuLink href="/products">Products</MenuLink>
        <MenuLink href="clients">Clients</MenuLink>
      </Menu>
    </Nav>
  )
}

export default Navbar
