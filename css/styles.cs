h1 {
  font-size: 45px;
}

html {
  font-family: "roboto";
}

button {
  cursor: pointer;
}

.location {
  display: flex;
  justify-content: center;
  width: 100%;
  height: 60px;
  background-color: #99E2D0;
  filter: brightness(105%);
}

.icon1 {
  font-size: 20px;
  background-color: #99E2D0;
  border: none;
}

.search_bar {
  width: 200px;
  display: flex;
  justify-content: center;
  border: none;
  background-color: #99E2D0;
  font-size: 20px;
  font-weight: bold;
  color: black;
}

.choice-card {
  display: flex;
  justify-content: space-between;
  width: 96%;
  border-radius: 25px;
  height: 75px;
  margin-top: 20px;
  padding-left: 2%;
  box-shadow: 0px 0px 15px #99E2D0;
  position: relative;
  top: 20px;
  cursor: pointer;
  opacity: 0%;
  transition: transform 4000ms;
  animation: menu-appearance 1s forwards;
}
@keyframes menu-appearance {
  from {
    opacity: 0%;
    transform: translateY(0);
  }
  to {
    opacity: 100%;
    transform: translateY(-20px);
  }
}

.choice-card:nth-child(2) {
  animation-delay: 0.4s;
}

.choice-card:nth-child(3) {
  animation-delay: 0.6s;
}

.choice-card:nth-child(4) {
  animation-delay: 0.8s;
}

.choice-card:nth-child(5) {
  animation-delay: 1s;
}

.price {
  font-size: 25px;
  width: 30%;
  height: 100%;
  display: flex;
  justify-content: flex-end;
  align-items: center;
  position: absolute;
  left: 105%;
}

.meal_check {
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #99E2D0;
  width: 60px;
  height: 75px;
  border-radius: 0 25px 25px 0;
  transform: scaleX(0);
  transform-origin: 100% 0%;
  transition: transform 1000ms;
}
.meal_check span {
  transform: rotate(180deg);
  transition: transform 1000ms;
  display: block;
}

.fa-check {
  color: #99E2D0;
  background-color: white;
  border-radius: 50px;
  width: 25px;
  height: 25px;
  font-size: 20px;
  padding-left: 5px;
  padding-top: 5px;
}

.text-area2 {
  display: flex;
  justify-content: space-between;
  width: 60%;
  padding: 0px 5%;
  transform-origin: left;
  transform: translateX(0px);
  transition: transform 1000ms;
}
.text-area2 span {
  transform: translateX(0);
  transition: transform 1000ms;
}
.text-area2:hover {
  transform: scale(1);
}
.text-area2:hover span {
  transform: translate(-30px);
}
.text-area2:hover + .meal_check {
  transform: translateX(-50px);
  opacity: 100%;
  transform: scaleX(1.1);
}
.text-area2:hover + .meal_check span {
  transform: rotate(360deg);
}

footer {
  position: relative;
  top: 50px;
  background-color: #2F4F4F;
  height: 160px;
}

.logo-footer {
  width: 20%;
  filter: brightness(2000%);
  position: relative;
  left: 2%;
  top: 20px;
}

ul {
  list-style-type: none;
  position: relative;
  right: 30px;
  top: 10px;
  color: white;
  font-size: 18px;
  margin-left: 10px;
}

.fa-utensils::before {
  font-size: 15px;
  margin-right: 10px;
  position: relative;
  bottom: 2px;
}

.fa-handshake-angle::before {
  font-size: 15px;
  margin-right: 5px;
  position: relative;
  bottom: 2px;
}

li {
  border-top: 20px;
}

@media screen and (min-width: 992px) {
  footer {
    display: flex;
    align-items: center;
    flex-direction: column;
    width: 100%;
  }
  .logo-footer {
    width: 200px;
    left: -4%;
  }
}
.contact {
  text-decoration: none;
  color: white;
}

.header-main {
  display: flex;
  justify-content: center;
  margin-top: 50px;
  margin-bottom: 5px;
  box-shadow: 0 5px 0 #99E2D0;
}

.header-other {
  display: flex;
  align-items: center;
}

.logo-header {
  width: 50%;
  margin-left: auto;
  margin-right: auto;
}

.button-arrow {
  font-size: 30px;
  background-color: white;
  border: none;
  cursor: pointer;
  color: black;
}

.background-loader {
  width: 100%;
  height: 100%;
  background-color: white;
  position: fixed;
  top: 0px;
  z-index: 100;
  display: flex;
  justify-content: center;
  align-items: center;
  animation: fadeout 0.2s 3s forwards;
}

@keyframes fadeout {
  from {
    opacity: 100%;
    transform: translateX(0);
  }
  to {
    opacity: 0%;
    transform: translateX(-9999px);
  }
}
.utensils-loader::before {
  font-size: 300px;
  color: #9356DC;
}

.utensils-loader {
  animation: rotation 1.6s alternate infinite ease;
}

@keyframes rotation {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(360deg);
  }
}
.title_area {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
  justify-content: center;
  flex-wrap: wrap;
  height: auto;
  background-color: whitesmoke;
}

.search_font {
  width: 25%;
  height: 50px;
  background: linear-gradient(#9356DC, #FF79DA);
  border-radius: 25px;
  color: white;
  font-size: 15px;
  border: none;
  box-shadow: 0 0 5px #FF79DA;
  cursor: pointer;
  font-weight: bold;
  margin: 30px;
  transition: transform 200ms;
}
.search_font:hover {
  transform: scale(1.05);
  filter: brightness(1.1);
}

.notice {
  display: flex;
  flex-direction: column;
}

.notice_area {
  width: 100%;
  height: 300px;
  display: flex;
  justify-content: space-around;
  align-items: center;
  flex-direction: column;
}

.notice_stage {
  box-shadow: 0 0 10px gray;
  width: 90%;
  height: 70px;
  border-radius: 25px;
  display: flex;
  align-items: center;
}

.notice_stage:hover {
  transform: scale(1.02);
  background-color: #f5edff;
}

.number_stage {
  width: 30px;
  height: 30px;
  border-radius: 25px;
  font-size: 15px;
  color: white;
  background-color: #9356DC;
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
  left: -15px;
}

.logo_stage {
  font-size: 20px;
}

.text_stage {
  font-size: 30px;
  margin-left: 40px;
  margin-right: 20px;
  font-weight: bold;
}

.restaurant-list {
  background-color: #99E2D0;
  filter: brightness(110%);
  display: flex;
  flex-direction: column;
  position: relative;
  top: 50px;
  align-items: center;
}

.restaurant-title {
  position: relative;
  left: -36%;
}

.restaurant-area {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  width: 100%;
}

.card-new {
  background-color: #99e2d0;
  border-radius: 5px;
  color: #1f997c;
  padding: 15px;
  margin-top: 20px;
  position: relative;
  left: 50px;
}

.restaurant-card {
  display: flex;
  flex-direction: column;
  width: 96%;
  background-color: white;
  border-radius: 25px;
  margin-bottom: 25px;
  height: 250px;
  box-shadow: 5px 5px 5px gray;
  transition: all 800ms;
}
.restaurant-card:hover {
  box-shadow: 0px 0px 25px black;
  filter: brightness(1.1);
}

.restaurant-link {
  width: 100%;
  height: 100%;
  color: black;
  text-decoration: none;
}

.restaurant-img {
  width: 100%;
  height: 70%;
}

.img-size {
  display: flex;
  border-radius: 25px 25px 0 0;
  width: 100%;
  height: 100%;
  overflow: hidden;
  object-fit: cover;
}

.text-area {
  display: flex;
  justify-content: space-between;
  position: relative;
  left: 2.5%;
  width: 90%;
  align-items: center;
}

h4 {
  margin: 15px 0 0 0;
  font-size: 25px;
  font-weight: bold;
}

.adress {
  margin: 5px 0 0 0;
  font-size: 20px;
}

.fa-heart {
  font-size: 30px;
  text-shadow: 0 0 5px black;
  color: white;
  transition: all 800ms;
}
.fa-heart:hover {
  color: #9356DC;
}

@media screen and (min-width: 992px) {
  .search_font {
    width: 25%;
  }
  .title_notice {
    display: flex;
    justify-content: center;
  }
  .notice_area {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    align-items: flex-start;
    height: auto;
  }
  .notice_stage {
    width: 30%;
  }
  .restaurant-title {
    display: flex;
    justify-content: center;
    left: 0px;
  }
  .restaurant-area {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
  }
  .restaurant-card {
    width: 45%;
  }
}
.img-area {
  display: block;
  width: 100%;
  height: 500px;
  overflow: hidden;
}

.restaurant-img-tall {
  width: 100%;
}

.meat-area {
  display: flex;
  flex-direction: column;
  border-radius: 25px 25px 0 0;
  position: relative;
  bottom: 200px;
  background-color: white;
}

.meat-area-title {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding-left: 2.5%;
  padding-right: 5%;
}

.choice-area {
  display: flex;
  flex-direction: column;
  margin-left: 2%;
  position: relative;
}

.choice-title {
  margin-left: 2%;
}

.title-meat {
  margin-bottom: 0;
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  width: 100%;
}

.underline {
  border-bottom: solid 3px #99E2D0;
}

.order_area {
  display: flex;
  justify-content: center;
  align-items: center;
}

.text-meal {
  overflow: hidden;
  white-space: nowrap;
  text-overflow: ellipsis;
  width: 100%;
}

.order_font {
  width: 50%;
  height: 50px;
  background: linear-gradient(#9356DC, #FF79DA);
  border-radius: 25px;
  color: white;
  font-size: 15px;
  border: none;
  box-shadow: 0 0 5px #FF79DA;
  cursor: pointer;
  font-weight: bold;
  position: relative;
  bottom: 120px;
}
.order_font:hover {
  transform: scale(1.05);
}

@media screen and (min-width: 992px) {
  .menu {
    display: flex;
    flex-direction: row;
  }
  .choice-area {
    width: 30%;
  }
}

/*# sourceMappingURL=styles.cs.map */
