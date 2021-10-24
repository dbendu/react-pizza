import React from 'react';
import { Route } from 'react-router-dom';

import { Header } from './components';
import { MainPage, CartPage } from './pages';

function App () {
  const [pizzas, setPizzas] = React.useState([])

  React.useEffect(() => {
    fetch('http://localhost:3000/db.json')
      .then((resp) => resp.json())
      .then((json) => setPizzas(json.pizzas))
  }, []);

  return (
    <div className="wrapper">
      <Header />
      <div className="content">
        <Route path="/" render={() => <MainPage pizzas={pizzas}/>} exact />
        <Route path="/cart" component={CartPage} exact />
      </div>
    </div>
  );
}

export default App