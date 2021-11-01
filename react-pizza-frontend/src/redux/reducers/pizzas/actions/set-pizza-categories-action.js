import { PizzaActions } from "../../actions-constants"

const setPizzasCategoriesAction = (pizzaCategories) => {
  return {
    type: PizzaActions.SetPizzaCategories,
    payload: pizzaCategories
  }
}

export default setPizzasCategoriesAction