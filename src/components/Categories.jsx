import React from "react";

function Categories({ categoriesList, activeCategoriesList }) {
  return (
    categoriesList.map(function (category) {
      let categoryClassName = activeCategoriesList.includes(category) ? 'active' : '';

      return <li
        onClick={() => {console.log({category})}}
        key={category}
        className={categoryClassName}>{category}
      </li>;
    }));
}

export default Categories;