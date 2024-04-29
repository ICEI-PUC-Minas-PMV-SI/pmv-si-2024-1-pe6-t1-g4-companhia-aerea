/* eslint-disable react/prop-types */
function Card({ title, children }) {
  return (
    <div className="card">
      <div className="title">
        <h3>{title}</h3>
      </div>
      {children}
    </div>
  );
}

export default Card;
