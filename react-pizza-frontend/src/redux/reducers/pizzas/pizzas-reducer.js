import { PizzaActions } from '../actions-constants'

const dataState = {
  isPizzasLoaded: false,
  isPizzaCategoriesLoaded: false
}

const isDataLoaded = () => {
  return dataState.isPizzasLoaded &&
    dataState.isPizzaCategoriesLoaded;
}

const initialState = {
  pizzas: [],
  pizzaCategories: [],
  isLoaded: false,

  activePizzas: []
}

const pizzasReducer = (state = initialState, action) => {
  if (action.type === PizzaActions.SetPizzas) {
    dataState.isPizzasLoaded = true;

    return {
      ...state,
      pizzas: action.payload,
      activePizzas: action.payload,
      isLoaded: isDataLoaded()
    }
  } else if (action.type === PizzaActions.SetPizzaCategories) {
    dataState.isPizzaCategoriesLoaded = true;

    return {
      ...state,
      pizzaCategories: action.payload,
      isLoaded: isDataLoaded()
    }
  } else if (action.type === PizzaActions.PizzaCategoriesFilterChanged) {
    var activeCategories = action.payload;
    var activePizzas = activeCategories.length === 0
      ? state.pizzas
      : state.pizzas.filter(p => activeCategories.includes(p.category));

    return {
      ...state,
      activePizzas: activePizzas
    }
  } else {
    return state
  }
}

export default pizzasReducer
