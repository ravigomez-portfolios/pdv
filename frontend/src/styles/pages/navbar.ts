import styled from 'styled-components'

export const Logo = styled.a`
  padding: 1rem 0;
  color: #635342;
  text-decoration: none;
  font-weight: 800;
  font-size: 1.7rem;

  span {
    font-weight: 300;
    font-size: 1.3rem;
  }
`
export const Nav = styled.div`
  padding: 0 2rem;
  display: flex;
  justify-content: space-between;
  align-items: center;
  flex-wrap: wrap;
  background: white;
`
export const Hamburger = styled.div`
  /* display: flex;
  flex-direction: column;
  cursor: pointer;

  span {
    height: 2px;
    width: 25px;
    background: #933623;
    margin-bottom: 4px;
    border-radius: 5px;
  }

  @media (max-width: 768px) {
    display: flex;

  } */
`

export const Menu = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  position: relative;

  @media (max-width: 768px) {
    overflow: hidden;
    flex-direction: column;
    width: 100%;
  }
`
export const MenuLink = styled.a`
  padding: 1rem 2rem;
  cursor: pointer;
  text-align: center;
  text-decoration: none;
  color: #128367;
  transition: all 0.3s ease-in;
  font-size: 0.9rem;

  &:hover {
    color: #887267;
  }
`
