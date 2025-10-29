(() => {
    "use strict"
    // ... (todo el código del selector de tema) ...
    const getStoredTheme = () => localStorage.getItem("theme")
    const setStoredTheme = theme => localStorage.setItem("theme", theme)

    const getPreferredTheme = () => {
        const storedTheme = getStoredTheme()
        if (storedTheme) {
            return storedTheme
        }

        return window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light"
    }

    const setTheme = theme => {
        if (theme === "auto") {
            document.documentElement.setAttribute("data-bs-theme", (window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light"))
        } else {
            document.documentElement.setAttribute("data-bs-theme", theme)
        }
    }

    const showActiveTheme = (theme) => {
        const iconElement = document.querySelector("#theme-icon");

        document.querySelectorAll("[data-bs-theme-value]").forEach(element => {
            element.classList.remove("active")
            element.setAttribute("aria-pressed", "false")
        })

        const btnToActive = document.querySelector(`[data-bs-theme-value="${theme}"]`)
        if (btnToActive) {
            btnToActive.classList.add("active")
            btnToActive.setAttribute("aria-pressed", "true")
        }

        if (iconElement) {
            iconElement.classList.remove("fa-sun", "fa-moon", "fa-circle-half-stroke");

            if (theme === "light") {
                iconElement.classList.add("fa-sun");
            } else if (theme === "dark") {
                iconElement.classList.add("fa-moon");
            } else if (theme === "auto") {
                iconElement.classList.add("fa-circle-half-stroke");
            }
        }
    }

    setTheme(getPreferredTheme())

    window.matchMedia("(prefers-color-scheme: dark)").addEventListener("change", () => {
        const storedTheme = getStoredTheme()
        if (storedTheme !== "light" && storedTheme !== "dark") {
            setTheme(getPreferredTheme())
            showActiveTheme(getPreferredTheme())
        }
    })

    window.addEventListener("DOMContentLoaded", () => {
        showActiveTheme(getPreferredTheme())

        document.querySelectorAll("[data-bs-theme-value]").forEach(toggle => {
            toggle.addEventListener("click", () => {
                const theme = toggle.getAttribute("data-bs-theme-value")
                setStoredTheme(theme)
                setTheme(theme)
                showActiveTheme(theme)
            })
        })
    })
})()

const logo = document.getElementById("logo")
logo.addEventListener("mouseover", () => {
    logo.src = "Images/logo.gif";
});

logo.addEventListener("mouseout", () => {
    logo.src = "Images/logo.jpg";
});