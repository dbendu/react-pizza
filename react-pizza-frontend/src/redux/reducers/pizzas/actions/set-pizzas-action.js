import { PizzaActions } from '../../actions-constants';

const calculateMinPizzaPrice = (pizza) => {
  return pizza.sizes.reduce(function (prev, cur) {
    return prev.price < cur.price ? prev : cur;
  }).price;
}

const mapPizzasToPizzasWithCalculatedMinPrice = (pizzas) => {
  return pizzas.map((pizza) => {
    return {
      ...pizza,
      minPrice: calculateMinPizzaPrice(pizza)
    }
  })
}

const setPizzasAction = (pizzas) => {
  pizzas = mapPizzasToPizzasWithCalculatedMinPrice(pizzas)

  return {
    type: PizzaActions.SetPizzas,
    payload: pizzas
  }
}

export default setPizzasAction